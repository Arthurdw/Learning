package ui.fx;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.util.Objects;
import java.util.ResourceBundle;

public class Program extends Application {
    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        ResourceBundle bundle = ResourceBundle.getBundle("i18n/login");
        Parent parent = FXMLLoader.load(Objects.requireNonNull(getClass().getResource("/ui/login.fxml")), bundle);
        primaryStage.setScene(new Scene(parent));
        primaryStage.show();
    }
}
