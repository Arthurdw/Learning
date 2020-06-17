// FireLoot - ©Arthurdw //
import React from 'react';

import ItemRarity from './ItemRarity';

class RecentBarItem extends React.Component {
    render() {
        return (
            <div className="RecentBarItem" style={{ borderColor: ItemRarity(this.props.rarity) }}>
                {this.props.iconName && <img className="RecentBarItemIcon" src={this.props.iconName === "plholder" ? "/./assets/plholder.png" : "/./assets/plholder.png"} alt={this.props.iconName} />}
                <p className="WearText">{this.props.wear}{this.props.StatTrack ? <span className="StatTrack"> ST</span> : ""}</p>
                <img className="RecentBarItemImage" src={this.props.image} alt={this.props.name} />
                <div className="RecentBarItemNameHolder">
                    <div className="RecentBarItemNameSubHolder">
                        <p className="RecentBarItemName">{this.props.type}</p>
                        <p className="RecentBarItemName">{this.props.skin}</p>
                    </div>
                </div>
            </div>
        );
    };
};

export default RecentBarItem;
