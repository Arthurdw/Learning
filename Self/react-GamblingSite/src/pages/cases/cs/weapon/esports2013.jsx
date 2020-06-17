// FireLoot - ©Arthurdw //
import React from 'react';

import Header from '../../../../components/content/Header';
import CaseContent from '../../../../components/content/CaseContent';
import Footer from '../../../../components/content/Footer';

function Esports2013Case() {
    return (
        <main id="content">
            <Header active="cs:go" />
            <CaseContent 
                name="CS:GO Weapon Case"
                pathInfo={[{name: "CS:GO Cases", url: "/"}, {name: "CS:GO Weapon Case", url: "/Open/WeaponCase"}]}
                price="2.00"
                contents={[
                    {name: "Knife", skin: "Unknown", rarity: "rare", image: "/./assets/skins/rare.webp"},
                    {name: "P90", skin: "Death by Kitty", rarity: "covert", image: "/./assets/skins/p90_deathbykitty.png"},
                    {name: "AK-47", skin: "Red Laminate", rarity: "classified", image: "/./assets/skins/ak47_redlaminate.png"},
                    {name: "AWP", skin: "BOOM", rarity: "classified", image: "/./assets/skins/awp_boom.png"},
                    {name: "P250", skin: "Splash", rarity: "restricted", image: "/./assets/skins/p250_splash.png"},
                    {name: "Galil AR", skin: "Orange DDPAT", rarity: "restricted", image: "/./assets/skins/galil_orangeddpat.png"},
                    {name: "Sawed-Off", skin: "Orange DDPAT", rarity: "restricted", image: "/./assets/skins/sawedoff_orangeddpat.png"},
                    {name: "M4A4", skin: "Faded Zebra", rarity: "mil-spec", image: "/./assets/skins/m4a4_fadedzebra.png"},
                    {name: "MAG-7", skin: "Memento", rarity: "mil-spec", image: "/./assets/skins/mag7_memento.png"},
                    {name: "FAMAS", skin: "Doomkitty", rarity: "mil-spec", image: "/./assets/skins/famas_doomkitty.png"}
                ]}
            />
            <Footer />
        </main>
    );
};

export default Esports2013Case;
