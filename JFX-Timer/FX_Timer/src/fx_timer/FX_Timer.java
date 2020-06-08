package fx_timer;

import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.input.MouseEvent;
import javafx.stage.Stage;
import javafx.stage.StageStyle;

public class FX_Timer extends Application {
	private double xOffset = 0;
	private double yOffset = 0;@Override
	public void start(Stage stage) throws Exception {
		Parent root = FXMLLoader.load(getClass().getResource("FXMLDocument.fxml"));
		stage.getIcons().add(new Image(getClass().getResourceAsStream("TimerIng.png")));

		root.setOnMousePressed(new EventHandler < MouseEvent > () {@Override
			public void handle(MouseEvent event) {
				xOffset = event.getSceneX();
				yOffset = event.getSceneY();
			}
		});
		root.setOnMouseDragged(new EventHandler < MouseEvent > () {@Override
			public void handle(MouseEvent event) {
				stage.setX(event.getScreenX() - xOffset);
				stage.setY(event.getScreenY() - yOffset);
			}
		});

		Scene scene = new Scene(root);
		stage.initStyle(StageStyle.UNDECORATED);
		stage.setScene(scene);
		stage.setResizable(false);
		stage.sizeToScene();
		stage.show();
		stage.setTitle("Timer Application");
	}

	/**
     * @param args the command line arguments
     */
	public static void main(String[] args) {
		launch(args);
	}

}
