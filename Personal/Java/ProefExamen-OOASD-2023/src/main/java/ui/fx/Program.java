package ui.fx;

import domain.MovieService;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;
import java.util.Objects;
import java.util.ResourceBundle;

public class Program extends Application {
    public static void main(String[] args) {
        launch(args);
    }

    public static void setScene(Stage stage, String scene, String title, MovieService service) throws IOException {
        ResourceBundle bundle = ResourceBundle.getBundle(String.format("i18n/%s", scene));
        FXMLLoader loader = new FXMLLoader(Objects.requireNonNull(Program.class.getResource(String.format("/ui/%s.fxml", scene))), bundle);
        Parent parent = loader.load();
        Controller controller = loader.getController();
        controller.setService(service);
        stage.setScene(new Scene(parent));
        stage.setTitle(title);
        stage.show();
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        MovieService service = new MovieService();
        setScene(primaryStage, "login", "Login or register required", service);
    }
}
