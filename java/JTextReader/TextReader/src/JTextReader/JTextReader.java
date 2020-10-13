/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package JTextReader;

import java.awt.Font;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.Timer;
import javax.swing.UIManager;

/**
 *
 * @author slxfld
 */
public class JTextReader implements ActionListener {
	JFrame frame;
	JPanel panel;

	JButton start;
	JButton stop;
	JButton clearb;

	JLabel wpm_label;
	JLabel word;
	boolean reading = false;

	Timer t1;

	JTextField wpm_text;
	JTextField read_text;

	String[] words;
	int Index;

	private JButton addnew_button(String title, int px, int py, int s1, int s2, ActionListener act) {
		JButton btn = new JButton(title);
		btn.setLocation(px, py);
		btn.setSize(s1, s2);
		btn.addActionListener(act);
		btn.setFont(new Font("Verdana", Font.PLAIN, 15));
		return btn;
	}
	public JTextReader() {
		frame = new JFrame("TextReader");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(550, 200);
		frame.setLocationRelativeTo(null);
		frame.setResizable(false);

		try {
			UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsClassicLookAndFeel");
		} catch(Exception e) {
			System.out.println("Error: " + e);
		}

		panel = new JPanel();
		panel.setLayout(null);

		clearb = addnew_button("clear", 270 - 85, 135, 80, 30, this);
		start = addnew_button("start", 270, 135, 80, 30, this);
		stop = addnew_button("stop", frame.getWidth() / 2 - 120 / 2, 135, 120, 30, this);
		stop.setVisible(false);

		wpm_text = new JTextField();
		wpm_text.setLocation(3, 135);
		wpm_text.setSize(40, 30);
		wpm_text.setFont(new Font("Verdana", Font.TYPE1_FONT, 13));

		read_text = new JTextField();
		read_text.setLocation(44, 135);
		read_text.setSize(140, 30);
		read_text.setFont(new Font("Verdana", Font.TYPE1_FONT, 13));
		read_text.setAutoscrolls(true);

		word = new JLabel("", SwingConstants.CENTER);
		word.setLocation(0, -15);
		word.setSize(frame.getWidth(), 100);
		word.setFont(new Font("Verdana", Font.PLAIN, 28));

		wpm_label = new JLabel("WPM | Text");
		wpm_label.setLocation(3, 110);
		wpm_label.setSize(160, 30);
		wpm_label.setFont(new Font("Verdana", Font.ITALIC, 13));

		panel.add(start);
		panel.add(stop);
		panel.add(clearb);
		panel.add(wpm_text);
		panel.add(wpm_label);
		panel.add(read_text);
		panel.add(word);

		frame.add(panel);
		frame.setVisible(true);
	}

	public static void main(String[] args) {
		JTextReader mcs = new JTextReader();
	}

	private void stop_reading() {
		reading = false;
		t1.stop();
		stop.setVisible(false);
		start.setVisible(true);
		wpm_text.setVisible(true);
		wpm_label.setVisible(true);
		read_text.setVisible(true);
		clearb.setVisible(true);
		wpm_label.setText("WPM | Text");
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		//Read
		if (reading) {
			word.setText(words[Index]);
			wpm_label.setText("" + Index + "/" + words.length);
			Index++;
			if (Index >= words.length) {
				stop_reading();
			}
		}

		//Start
		if (e.getSource() == start && reading == false) {

			int WPM = 60000 / Integer.parseInt(wpm_text.getText());

			t1 = new Timer(WPM, this);
			t1.start();
			reading = true;
			String word_text = "5 4 3 2 1" + read_text.getText();
			words = word_text.split(" ");
			Index = 0;
			start.setVisible(false);
			wpm_text.setVisible(false);
			// wpm_label.setVisible(false);
			read_text.setVisible(false);
			clearb.setVisible(false);
			stop.setVisible(true);
			try {} catch(Exception ex) {}
		}
		//Stop  
		if (e.getSource() == stop) {
			stop_reading();
			try {} catch(Exception ex) {}
		}
		//Clear  
		if (e.getSource() == clearb) {
			read_text.setText("");
			try {} catch(Exception ex) {}
		}
	}

}