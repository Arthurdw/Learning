// FireLoot - ©Arthurdw //
import React from 'react';

import RecentBarItem from '../utils/RecentBarItem';

class RecentBar extends React.Component {
    render() {
        return (
            <div id="RecentBar">
                <RecentBarItem
                    type = "Knife"
                    skin = "Crimson Web"
                    wear = "BS"
                    rarity = "consumer"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem 
                    type = "Knife"
                    skin = "Crimson Web"
                    wear = "MW"
                    rarity = "industrial"
                    StatTrack = "true"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem
                    type = "Knife"
                    skin = "Crimson Web"
                    wear = "WW"
                    rarity = "mil-spec"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem
                    type = "Knife"
                    skin = "Crimson Web"
                    wear = "FN"
                    rarity = "restricted"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem 
                    type = "Knife"
                    skin = "Crimson Web"
                    iconName = "pl"
                    wear = "FN"
                    rarity = "classified"
                    StatTrack = "true"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem
                    type = "Knife"
                    skin = "Crimson Web"
                    iconName = "pl"
                    wear = "BS"
                    rarity = "covert"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem 
                    type = "Knife"
                    skin = "Crimson Web"
                    iconName = "pl"
                    wear = "MW"
                    rarity = "rare"
                    StatTrack = "true"
                    image = "/./assets/placeholder.png"
                />
                <RecentBarItem
                    type = "Knife"
                    skin = "Crimson Web"
                    wear = "BS"
                    rarity = "contraband"
                    image = "/./assets/placeholder.png"
                />
            </div>
        );
    };
};

export default RecentBar;
