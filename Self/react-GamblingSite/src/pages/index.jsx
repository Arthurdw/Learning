// FireLoot - ©Arthurdw //
import React from 'react';

import Header from '../components/content/Header';
import Content from '../components/content/Content';
import Footer from '../components/content/Footer';

function HomePage() {
    return (
        <main id="content">
            <Header active="cs:go" />
            <Content />
            <Footer />
        </main>
    )
}

export default HomePage;
