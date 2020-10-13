package pointconnect;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.util.ArrayList;
import java.util.Random;
import javax.imageio.ImageIO;
import javax.swing.JPanel;
import javax.swing.Timer;

class JPaintPanel extends JPanel implements ActionListener,
MouseListener,
MouseMotionListener {

	private Timer t1;
	private int tick = 0;
	private ArrayList < Dot > dots;
	private Dot grabbed_Dot;
	private double MouseX = 0;
	private double MouseY = 0;

	private static int Number_Of_Dots = 300;

	Random rand;

	JPaintPanel(int width, int height) {
		//load 
		t1 = new Timer(1, this);
		t1.start();
		dots = new ArrayList();
		rand = new Random();
		for (int i = 0; i < Number_Of_Dots; i++) {
			int zz1 = rand.nextInt(width) + 30;
			int zz2 = rand.nextInt(height - 150) + 30;
			dots.add(new Dot(zz1, zz2, 10));
		}
		this.addMouseListener(this);
		this.addMouseMotionListener(this);
		grabbed_Dot = new Dot(0, 0, 20);
	}

	@Override
	public void paintComponent(Graphics g) {
		super.paintComponent(g);
		g.setColor(Color.white);
		g.fillRect(0, 0, this.getWidth(), this.getHeight());

		for (Dot d: dots) {
			//shake
			double ch_x = (rand.nextInt(101) - 50) / 30;
			double ch_y = (rand.nextInt(101) - 50) / 30;

			d.move(MouseX, MouseY);
		}

		for (Dot d: dots) {
			d.draw(g);

			// int dot_count = 0;
			for (Dot dt: dots) {
				if (d.draw_distance_to_dot(dt, g)) {
					//        if(dt.frozen){
					//            d.frozen=true;
					//        }
				}
			}
		}

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// tick++;
		repaint();
	}

	@Override
	public void mousePressed(MouseEvent e) {
		boolean found = false;
		for (Dot d: dots) {
			if (d.check_for_click(e.getX(), e.getY()) == true) {
				grabbed_Dot = d;
				found = true;
				break;
			}
		}
		if (!found) {
			Dot newdot = new Dot(e.getX(), e.getY(), 10);
			newdot.frozen = false;
			dots.add(newdot);
		}
		repaint();
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		for (Dot d: dots) {
			grabbed_Dot.release_grab();
		}
		repaint();
	}@Override public void mouseClicked(MouseEvent e) {}@Override public void mouseEntered(MouseEvent e) {}@Override public void mouseExited(MouseEvent e) {}

	@Override
	public void mouseDragged(MouseEvent e) {
		try {
			grabbed_Dot.update(e.getX(), e.getY());
		} catch(Exception es) {}
		//  repaint();
	}

	@Override
	public void mouseMoved(MouseEvent e) {
		try {
			grabbed_Dot.update(e.getX(), e.getY());
		} catch(Exception es) {}
		//   repaint();
		MouseX = e.getX();
		MouseY = e.getY();
	}

}