import React from 'react';

import ItemRarity from './ItemRarity';

class CaseSkin extends React.Component {
    render() {
        return (
        <div className={this.props.extraClass ? `CaseSkin ${this.props.extraClass}` : "CaseSkin"}>
            <div className="rarity" style={{backgroundColor: ItemRarity(this.props.skin.rarity)}} ></div>
            <img src={this.props.skin.image} alt={`${this.props.skin.name} ${this.props.skin.skin}`}/>
            <p>{this.props.skin.name}</p>
            <p>{this.props.skin.skin}</p>
        </div>
        ); 
    };
};

export default CaseSkin;
