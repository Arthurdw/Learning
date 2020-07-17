// FireLoot - ©Arthurdw //
import React from 'react';

import Header from '../../../../components/content/Header';
import CaseContent from '../../../../components/content/CaseContent';
import Footer from '../../../../components/content/Footer';

function WeaponCase() {
    return (
        <main id="content">
            <Header active="cs:go" />
            <CaseContent 
                name="CS:GO Weapon Case"
                pathInfo={[{name: "CS:GO Cases", url: "/"}, {name: "CS:GO Weapon Case", url: "/Open/WeaponCase"}]}
                price="5.00"
                contents={[
                    {name: "Knife", skin: "Unknown", rarity: "rare", image: "/./assets/skins/rare.webp"},
                    {name: "AWP", skin: "Lightning Strike", rarity: "covert", image: "/./assets/skins/awp_lightning.png"},
                    {name: "AK-47", skin: "Case Hardened", rarity: "classified", image: "/./assets/skins/ak47_casehardened.png"},
                    {name: "Dessert Eagle", skin: "Hypnotic", rarity: "classified", image: "/./assets/skins/deagle_hypnotic.png"},
                    {name: "Glock", skin: "Dragon Tattoo", rarity: "restricted", image: "/./assets/skins/glock_dragontattoo.png"},
                    {name: "M4A1-S", skin: "Dark Water", rarity: "restricted", image: "/./assets/skins/m4a1s_darkwater.png"},
                    {name: "USP-S", skin: "Dark Water", rarity: "restricted", image: "/./assets/skins/usp_darkwater.png"},
                    {name: "SG 553", skin: "Ultraviolet", rarity: "mil-spec", image: "/./assets/skins/sg553_ultraviolet.png"},
                    {name: "AUG", skin: "Wings", rarity: "mil-spec", image: "/./assets/skins/aug_wings.png"},
                    {name: "MP-7", skin: "Skulls", rarity: "mil-spec", image: "/./assets/skins/mp7_skulls.png"}
                ]}
            />
            <Footer />
        </main>
    );
};

export default WeaponCase;
