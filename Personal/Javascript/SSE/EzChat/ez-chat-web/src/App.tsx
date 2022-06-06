import React from "react";
import {
  BrowserRouter as Router,
  Route,
  Switch,
  Redirect,
} from "react-router-dom";
import ChatRoom from "./ChatRoom";

class App extends React.Component {
  render() {
    return (
      <Router>
        <Switch>
          <Route exact path="/" component={ChatRoom} />
          <Redirect to="/" />
        </Switch>
      </Router>
    );
  }
}

export default App;
