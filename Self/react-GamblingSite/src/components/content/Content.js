// FireLoot - ©Arthurdw //
import React from 'react';

import RecentBar from '../utils/RecentBar';
import CaseSection from '../utils/CaseSection';


function Content() {
    return (
        <main>
            <RecentBar />
            {/* <StatsSection /> */}
            {/* <PremiumSection /> */}
            <CaseSection
                title="CS:GO Cases"
                description="The classical cases you always loved... but these ones are better!"
                cases={[
                    { name: "CS:GO Weapon Case", image: "./assets/cases/weapon.png", price: "5.00", url: "Open/WeaponCase" },
                    { name: "ESports 2013 Case", image: "./assets/cases/esports_2013.png", price: "2.00", url: "Open/Esports2013Case" },
                    { name: "Operation Bravo Case", image: "./assets/cases/bravo.png", price: "2.50", url: "Open/BravoCase" }//,
                    // { name: "CS:GO Weapon Case 2", image: "./assets/cases/weapon_2.png", price: "2.00", url: "#" },
                    // { name: "eSports 2013 Winter Case", image: "./assets/cases/esports_winter_2013.png", price: "1.50", url: "#" },
                    // { name: "Winter Offensive Weapon Case", image: "./assets/cases/winter_offensive.png", price: "1.50", url: "#" },
                    // { name: "CS:GO Weapon Case 3", image: "./assets/cases/weapon_3.png", price: "1.50", url: "#" },
                    // { name: "Huntsman Weapon Case", image: "./assets/cases/huntsman.png", price: "1.50", url: "#" },
                    // { name: "Operation Breakout Weapon Case", image: "./assets/cases/breakout.png", price: "1.50", url: "#" },
                    // { name: "ESports 2014 Summer", image: "./assets/cases/esports_summer_2014.png", price: "1.50", url: "#" },
                    // { name: "Operation Vanguard", image: "./assets/cases/vanguard.png", price: "1.50", url: "#" },
                    // { name: "Chroma Case", image: "./assets/cases/chroma.png", price: "1.50", url: "#" },
                    // { name: "Chroma 2 Case", image: "./assets/cases/chroma2.png", price: "1.50", url: "#" },
                    // { name: "Falchion Case", image: "./assets/cases/falchion.png", price: "1.50", url: "#" },
                    // { name: "Shadow Case", image: "./assets/cases/shadow.png", price: "1.50", url: "#" },
                    // { name: "Revolver Case", image: "./assets/cases/revolver.png", price: "1.50", url: "#" },
                    // { name: "Operation Wildfire", image: "./assets/cases/wildfire.png", price: "1.50", url: "#" },
                    // { name: "Chroma 3", image: "./assets/cases/chroma3.png", price: "2.00", url: "#" },
                    // { name: "Gamma Case", image: "./assets/cases/gamma.png", price: "2.00", url: "#" },
                    // { name: "Gamma 2 Case", image: "./assets/cases/gamma2.png", price: "2.00", url: "#" },
                    // { name: "Glove Case", image: "./assets/cases/glove.png", price: "2.00", url: "#" },
                    // { name: "Spectrum Case", image: "./assets/cases/spectrum.png", price: "2.00", url: "#" },
                    // { name: "Hydra Case", image: "./assets/cases/hydra.png", price: "2.00", url: "#" },
                    // { name: "Spectrum 2 Case", image: "./assets/cases/spectrum2.png", price: "5.00", url: "#" },
                    // { name: "Clutch Case", image: "./assets/cases/clutch.png", price: "5.00", url: "#" },
                    // { name: "Horizon Case", image: "./assets/cases/horizon.png", price: "2.00", url: "#" },
                    // { name: "Danger Zone Case", image: "./assets/cases/dangerzone.png", price: "2.00", url: "#" },
                    // { name: "Prisma Case", image: "./assets/cases/prisma.png", price: "2.00", url: "#" },
                    // { name: "CS20 Case", image: "./assets/cases/cs20.png", price: "2.00", url: "#" },
                    // { name: "Shattered Web Case", image: "./assets/cases/shatteredweb.png", price: "1.50", url: "#" },
                    // { name: "Prisma 2 Case", image: "./assets/cases/prisma2.png", price: "1.50", url: "#" }
                ]} />
        </main>
    );
};

export default Content;
