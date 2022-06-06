// FireLoot - ©Arthurdw //
import React from 'react';

import Header from '../../../../components/content/Header';
import CaseContent from '../../../../components/content/CaseContent';
import Footer from '../../../../components/content/Footer';

function BravoCase() {
    return (
        <main id="content">
            <Header active="cs:go" />
            <CaseContent 
                name="CS:GO Weapon Case"
                pathInfo={[{name: "CS:GO Cases", url: "/"}, {name: "CS:GO Weapon Case", url: "/Open/WeaponCase"}]}
                price="2.50"
                contents={[
                    {name: "Knife", skin: "Unknown", rarity: "rare", image: "/./assets/skins/rare.webp"},
                    {name: "AK-47", skin: "Fire Serpent", rarity: "covert", image: "/./assets/skins/ak47_fireserpent.png"},
                    {name: "Dessert Eagle", skin: "Golden Koi", rarity: "covert", image: "/./assets/skins/deagle_goldenkoi.png"},
                    {name: "P90", skin: "Emerald Dragon", rarity: "classified", image: "/./assets/skins/p90_emeralddragon.png"},
                    {name: "AWP", skin: "Graphite", rarity: "classified", image: "/./assets/skins/awp_graphite.png"},
                    {name: "P2000", skin: "Ocean Foam", rarity: "classified", image: "/./assets/skins/p2000_oceanfoam.png"},
                    {name: "USP-S", skin: "Overgrowth", rarity: "restricted", image: "/./assets/skins/usp_overgrowth.png"},
                    {name: "MAC-10", skin: "Graven", rarity: "restricted", image: "/./assets/skins/mac10_graven.png"},
                    {name: "M4A4", skin: "Zirka", rarity: "restricted", image: "/./assets/skins/m4a4_zirka.png"},
                    {name: "M4A1-S", skin: "Bright Water", rarity: "restricted", image: "/./assets/skins/m4a1s_brightwater.png"},
                    {name: "Galil AR", skin: "Shattered", rarity: "mil-spec", image: "/./assets/skins/galil_shattered.png"},
                    {name: "SG 553", skin: "Wave Spray", rarity: "mil-spec", image: "/./assets/skins/sg553_wavespray.png"},
                    {name: "UMP-45", skin: "Bone Pile", rarity: "mil-spec", image: "/./assets/skins/ump_bonepile.png"},
                    {name: "Nova", skin: "Tempest", rarity: "mil-spec", image: "/./assets/skins/nova_tempest.png"},
                    {name: "Dual Berettas", skin: "Black Limba", rarity: "mil-spec", image: "/./assets/skins/beretta_blacklimba.png"},
                    {name: "G3SG1", skin: "Demeter", rarity: "mil-spec", image: "/./assets/skins/g3sg1_demeter.png"}
                ]}
            />
            <Footer />
        </main>
    );
};

export default BravoCase;
