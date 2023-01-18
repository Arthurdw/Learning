package ui.fx;

import domain.MovieService;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.Spinner;
import javafx.scene.control.TextField;
import javafx.scene.image.ImageView;

import java.util.logging.Level;
import java.util.logging.Logger;

public class MovieController implements Controller {
    private static final Logger LOGGER = Logger.getLogger(MovieController.class.getName());
    @FXML
    public ListView listMovies;
    @FXML
    public ImageView imgMovie;
    @FXML
    public TextField txtReview;
    @FXML
    public Spinner spinScore;
    @FXML
    public Label lblMovie;
    private MovieService service;

    public MovieController() {
        LOGGER.log(Level.INFO, "MovieController created");
    }

    public void btnSearch(ActionEvent actionEvent) {
    }

    public void btnDisplayMovie(ActionEvent actionEvent) {
    }

    public void btnSubmit(ActionEvent actionEvent) {
    }

    @Override
    public void setService(MovieService service) {
        this.service = service;
        LOGGER.log(Level.INFO, "Set the service for the movie controller");
    }
}
