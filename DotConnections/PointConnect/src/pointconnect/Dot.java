package pointconnect;

import java.awt.Color;
import java.awt.Graphics;

/**
 *
 * @author simon
 */
public class Dot {

	private double x;
	private double y;
	private double vel_x;
	private double vel_y;

	private double radius;
	private boolean grabbed = false;
	public boolean frozen = false;
	public boolean bottomed = false;
	private double distance = 120;
	public boolean changed = false;
	private double speed = 0;
	private double speed_increase = 0.2;

	public Dot(double _x, double _y, double _radius) {
		this.x = _x;
		this.y = _y;
		this.radius = _radius;
	}

	public void draw(Graphics g) {
		g.setColor(Color.red);
		g.drawOval((int)(x - radius / 2), (int)(y - radius / 2), (int) radius, (int) radius);
		g.setColor(Color.black);
		g.fillOval((int)((x + 1) - radius / 2), (int)((y + 1) - radius / 2), (int) radius - 2, (int) radius - 2);
	}

	public void update(double mouseX, double mouseY) {
		if (grabbed) {
			this.x = mouseX;
			this.y = mouseY;
		}

	}

	public boolean draw_distance_to_dot(Dot dt, Graphics g) {

		double dis = Math.sqrt((dt.x - this.x) * (dt.x - this.x) + (dt.y - this.y) * (dt.y - this.y));

		if (dis < distance && dis > -distance) {
			g.drawLine((int) this.x, (int) this.y, (int) dt.x, (int) dt.y);
			return true;
		}
		return false;
	}

	public void release_grab() {
		grabbed = false;
	}

	public void move(double in , double in2) {
		double dis = Math.sqrt(( in -this.x) * ( in -this.x) + (in2 - this.y) * (in2 - this.y));
		if (dis < 200 && dis > -200) {
			speed = speed + speed_increase;
		}
		if (speed > 0) {
			speed -= (speed_increase / 2);
		}
		if (speed < 0) {
			speed = 0;
		}

		double deltax = in-x;
		double deltay = in2 - y;

		double direction = Math.atan2(deltay, deltax);

		x = (x + (speed * -Math.cos(direction)));
		y = (y + (speed * -Math.sin(direction)));

		if (!frozen) {
			// x+=in;
			// y+=in2+0;
			//if(y>900){frozen=true; bottomed=true;}
			if (y > 900) {
				y = 900;
			}
			if (x > 1800) {
				x = 1800;
			}
			if (x < 10) {
				x = 10;
			}
			if (y < 10) {
				y = 10;
			}
			if (y > 900) {
				y = 900;
			}
		}
	}

	public boolean check_for_click(double cur_x, double cur_y) {
		if (cur_x > x - (radius / 2) && cur_x < x - (radius / 2) + radius && cur_y > y - (radius / 2) && cur_y < y - (radius / 2) + radius) {
			grabbed = true;
			return true;
		}
		return false;
	}

}