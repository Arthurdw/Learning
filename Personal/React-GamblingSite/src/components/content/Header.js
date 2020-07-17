// FireLoot - ©Arthurdw //
import React from 'react';

import { Link } from 'react-router-dom';

import GameSection from '../utils/GameSection';

function Header(props) {
    return (
        <header>
            <Link to="/" >
                <div id="ico">
                    <img id="HeaderIcon" src="/./assets/IconFullLow.png" alt="The FireLoot Icon" />
                    <h1 id="SiteText">FireLoot</h1>
                </div>
            </Link>
            <div id="games">
                <Link to="/" ><GameSection name="CS:GO" picture="/./assets/cs-icon-small.png" active={props.active === "cs:go" ? "true" : null} /></Link>
                <Link to="/dota"><GameSection name="DOTA" picture="/./assets/dota2.svg" active={props.active === "dota" ? "true" : null} /></Link>
            </div>
        </header>
    );
};

export default Header;
