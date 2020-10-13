package fx_timer;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.media.AudioClip;
import javafx.util.Duration;

public class FXMLDocumentController implements Initializable {

	@FXML
	private Button button_start;@FXML
	private TextField txt_input;@FXML
	private Label Time_label;

	public Timeline timeline;
	private Timeline tn;
	private int minutes;
	private int seconds;
	private int milli;

	private String milli_string;
	private String second_string;
	private String minute_string;

	private boolean running;

	@FXML
	private void handle_abort(MouseEvent event) {

		Platform.exit();

	}

	@FXML
	private void handleButtonAction(ActionEvent event) {

		if (running == false) {
			try {
				minutes = Integer.parseInt(txt_input.getText());
				if (minutes != 0 && minutes > 0) {
					seconds = 59;
					minutes--;
					timeline = new Timeline(new KeyFrame(Duration.millis(10), e - >run()));
					timeline.setCycleCount(Timeline.INDEFINITE);
					timeline.play();
					running = true;
					txt_input.setVisible(false);
					button_start.setVisible(false);
				}
			} catch(Exception e) {}
		}

	}

	@FXML
	private void handlestop(ActionEvent event) {

		Platform.exit();
	}

	public void run() {
		if (seconds == 0 && minutes != 0) {
			seconds = 59;
			minutes--;
		}
		if (milli == 0 && seconds != 0) {
			milli = 100;
			seconds--;
		}

		milli--;

		if (milli < 10) {
			milli_string = "0" + milli;
		}
		else {
			milli_string = "" + milli;
		}

		if (seconds < 10) {
			second_string = "0" + seconds;
		}
		else {
			second_string = "" + seconds;
		}

		if (minutes < 10) {
			minute_string = "0" + minutes;
		}
		else {
			minute_string = "" + minutes;
		}

		Time_label.setText("" + minute_string + ":" + second_string + ":" + milli_string);

		if (minutes == 0 && seconds == 0 && milli == 0) {
			timeline.stop();
			Time_label.setText("00:00:00");
			running = false;
			txt_input.setVisible(true);
			button_start.setVisible(true);

		}

	}

	@Override
	public void initialize(URL location, ResourceBundle resources) {
		//  iv.setImage(new Image(getClass().getResource("testimage.jpg").toExternalForm()));
	}

}