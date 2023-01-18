package ui.fx;

import domain.MovieService;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.util.function.BooleanSupplier;
import java.util.logging.Level;
import java.util.logging.Logger;

public class LoginController implements Controller {
    private static final Logger LOGGER = Logger.getLogger(LoginController.class.getName());
    private MovieService service;

    @FXML
    private Label lblErrorMessage;
    @FXML
    private TextField txtUsername;
    @FXML
    private TextField txtPassword;
    @FXML
    private Button btnLogin;

    public LoginController() {
        LOGGER.log(Level.INFO, "LoginController created");
    }

    public void setService(MovieService service) {
        this.service = service;
        LOGGER.log(Level.INFO, "Set the service for the login controller");
    }

    private void predicateAction(BooleanSupplier method, String errorMessage) {
        boolean success = method.getAsBoolean();

        if (success) showMovieReviewScreen();
        else showErrorMessage(errorMessage);
    }

    public void onLogin() {
        predicateAction(
                () -> service.login(txtUsername.getText(), txtPassword.getText()),
                "Invalid username or password"
        );
    }

    public void onRegister() {
        predicateAction(
                () -> service.register(txtUsername.getText(), txtPassword.getText()),
                "Username already exists/invalid data"
        );
    }

    public void showErrorMessage(String message) {
        LOGGER.log(Level.INFO, "Showing error message: {0}", message);
        lblErrorMessage.setOpacity(1);
        lblErrorMessage.setText(message);
    }

    private void showMovieReviewScreen() {
        LOGGER.log(Level.INFO, "Switching from login to movie review screen");
        try {
            Stage stage = (Stage) btnLogin.getScene().getWindow();
            Program.setScene(stage, "movie-review", "Movie review", service);
            LOGGER.log(Level.INFO, "Switched from login to movie review screen");
        } catch (Exception e) {
            LOGGER.log(Level.SEVERE, "Failed to switch to movie review screen", e);
            showErrorMessage("Failed to switch to movie review screen");
        }
    }
}
