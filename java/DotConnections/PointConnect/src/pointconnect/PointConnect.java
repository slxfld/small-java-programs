package pointconnect;

import java.awt.Dimension;
import java.awt.Toolkit;
import java.util.ArrayList;
import javax.swing.JFrame;

/**
 *
 * @author slxfld
 */
public class PointConnect extends JFrame {
	JPaintPanel panel;

	PointConnect() {

		Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
		double width = screenSize.getWidth();
		double height = screenSize.getHeight();

		panel = new JPaintPanel((int) width, (int) height);
		panel.setSize((int) width, (int) height);
		this.add(panel);

		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize((int) width, (int) height);
		this.show();
	}

	public static void main(String[] args) {
		PointConnect pc = new PointConnect();
	}

}