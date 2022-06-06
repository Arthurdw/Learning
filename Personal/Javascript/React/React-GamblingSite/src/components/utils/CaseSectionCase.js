// FireLoot - ©Arthurdw //
import React from 'react';

class CaseSectionCase extends React.Component {
    render() {
        return (
            <a href={this.props.url} className="CaseSectionCaseURL">
                <div className="CaseSectionCase">
                    <p className="CaseSectionCaseTitle">{this.props.name}</p>
                    <img src={this.props.image} alt={`${this.props.name} Case`} />
                    <p className="CaseSectionCasePrice">{this.props.price}</p>
                </div>
            </a>
        )
    };
};

export default CaseSectionCase;
