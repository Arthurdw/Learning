import React from 'react';
import UIfx from 'uifx';

import tickSound from '../../assets/tick.mp3'
import CaseSkin from './CaseSkin';

// Chances:
// Blue: 79.92%
// Purple: 15.98%
// Pink: 3.2%
// Red: 0.64%
// Yellow: 0.26%

const BreakException = {};
const tick = new UIfx(tickSound);

function randomFloat(min, max) {
    return Math.random() * (max - min + 1) + min;
}

function randomInt(min, max) {
    return Math.floor(Math.random() * (max - min) + min);
}

class CaseOpener extends React.Component {
    constructor(props) {
        super(props);
        this.startSpin = this.startSpin.bind(this);
        this.setupItems = this.setupItems.bind(this);
        this.getItem = this.getItem.bind(this);

        this.state = {
            spinning: false,
            usable: {
                consumer: { chance: 0, items: [] },
                industrial: { chance: 0, items: [] },
                mil_spec: { chance: 79.92, items: [] },
                restricted: { chance: 95.9, items: [] },
                classified: { chance: 99.1, items: [] },
                covert: { chance: 99.74, items: [] },
                rare: { chance: 100, items: [] },
                contraband: { chance: 0, items: [] }
            },

            cases: []
        };
    };

    componentDidMount() {
        this.setupItems();
        this.setState({
            cases: [
                <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />,
                <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />,
                <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />,
                <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />,
                <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />]
        });
    };

    render() {
        return (
            <div id="CaseOpener">
                {/* <p>Cases to open</p> */}
                {/* {this.state.cases.map(x => x)} */}
                {this.state.cases[0]}
                {this.state.cases[1]}
                {this.state.cases[2]}
                {this.state.cases[3]}
                {this.state.cases[4]}
                <div id="OpenCase">
                    <button onClick={this.startSpin}>OPEN - <span className="CaseSectionCasePrice">{this.props.price}</span></button>
                </div>
                <div id="WinnerPicker"></div>
            </div>
        );
    };

    async startSpin() {
        if (this.state.spinning) return;
        await this.setState({ spinning: true });
        let cooldown = 10;
        for (let i = 0; i < 40; i++) {
            let clone = { ...this.state };
            clone.cases = [clone.cases[1], clone.cases[2], clone.cases[3], clone.cases[4], <CaseSkin extraClass="SmallerCaseSkin" skin={this.getItem()} />];
            this.setState(clone);
            tick.play();
            await this.sleep(cooldown);
            cooldown += 6;
        }
        this.setState({ spinning: false });
    };

    getItem() {
        let last = 0;
        const num = randomFloat(0, 99);
        let val;
        try {
            [this.state.usable.consumer, this.state.usable.industrial, this.state.usable.mil_spec,
            this.state.usable.restricted, this.state.usable.classified, this.state.usable.covert,
            this.state.usable.rare, this.state.usable.contraband].forEach(item => {
                if (num < item.chance && num > last) {
                    val = item.items[randomInt(0, item.items.length)];
                    throw BreakException;
                } else last = item.chance;
            })
        } catch (e) {
            if (e !== BreakException) throw e;
        };

        return val;
    };

    async setupItems() {
        let clone = { ...this.state };
        this.props.items.forEach(item => {
            switch (item.rarity) {
                case 'industrial':
                    clone.usable.industrial.items.push(item);
                    break;
                case 'mil-spec':
                    clone.usable.mil_spec.items.push(item);
                    break;
                case 'restricted':
                    clone.usable.restricted.items.push(item);
                    break;
                case 'classified':
                    clone.usable.classified.items.push(item);
                    break;
                case 'covert':
                    clone.usable.covert.items.push(item);
                    break;
                case 'rare':
                    clone.usable.rare.items.push(item);
                    break;
                case 'contraband':
                    clone.usable.contraband.items.push(item);
                    break;
                case "consumer":
                default:
                    clone.usable.consumer.items.push(item);
            }
        })
        await this.setState(clone);
    };

    sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
};

export default CaseOpener;
