// FireLoot - ©Arthurdw //
import React from 'react';

class GameSection extends React.Component {
    render() {
        const data = this.props.active ?
            <img id="GameSectionActiveIcon" src={this.props.picture} alt={`GameSection icon for ${this.props.name}!`} /> :
            <img src={this.props.picture} alt={`GameSection icon for ${this.props.name}!`} />;
        return <div className="GameSectionIcon">{data}</div>
    };
};

export default GameSection;
