// FireLoot - ©Arthurdw //
import React from 'react';

import {
    BrowserRouter as Router,
    Route,
    Switch,
    Redirect
} from 'react-router-dom';

import HomePage from './pages';
import PageNotFound from './pages/404'

import WeaponCase from './pages/cases/cs/weapon/weapon';
import Esports2013Case from './pages/cases/cs/weapon/esports2013';
import BravoCase from './pages/cases/cs/weapon/bravo';


class App extends React.Component {
    render() {
        return (
            <Router>
                <Switch>
                    <Redirect exact path="/" to="/cs-go" />
                    <Route exact path="/cs-go" component={HomePage} />
                    <Route exact path="/404" component={PageNotFound} />
                    <Route exact path="/Open/WeaponCase" component={WeaponCase} />
                    <Route exact path="/Open/Esports2013Case" component={Esports2013Case} />
                    <Route exact path="/Open/BravoCase" component={BravoCase} />
                    <Redirect to="/404" />
                </Switch>
            </Router>
        )
    }
}

export default App;
