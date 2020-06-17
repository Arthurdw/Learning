// FireLoot - ©Arthurdw //
import React from 'react';

import { Link } from 'react-router-dom';

import Header from '../components/content/Header';
import Footer from '../components/content/Footer';

function PageNotFound() {
    return (
        <main id="content">
            <Header />
            <div id="PageNotFound">
                <h1>ERROR <span className="red">404</span></h1>
                <h2>Page Not Found</h2>
                <Link to="/">Return to homepage</Link>
            </div>
            <Footer />
        </main>
    )
}

export default PageNotFound;
