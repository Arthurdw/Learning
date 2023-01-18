package ui.fx;

import domain.MovieService;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

import java.util.function.Supplier;
import java.util.logging.Level;
import java.util.logging.Logger;

public class LoginController {
    private static final Logger LOGGER = Logger.getLogger(LoginController.class.getName());
    private final MovieService service;

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
        this.service = new MovieService();
    }

    private void predicateAction(Supplier<Boolean> method, String errorMessage) {
        boolean success = method.get();

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
                "Username already exists"
        );
    }

    public void showErrorMessage(String message) {
        lblErrorMessage.setOpacity(1);
        lblErrorMessage.setText(message);
    }

    private void showMovieReviewScreen() {
    }
}
