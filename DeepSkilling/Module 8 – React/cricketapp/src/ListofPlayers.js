import React from "react";

const players = [
    { name: "Ben Stokes", score: 50 },
    { name: "Jos Buttler", score: 70 },
    { name: "Jonny Bairstow", score: 40 },
    { name: "Vaibhav Suryavansi", score: 61 },
    { name: "Rishabh Pant", score: 61 },
    { name: "Sachin", score: 95 },
    { name: "Dhoni", score: 100 },
    { name: "Virat", score: 84 },
    { name: "Jadeja", score: 64 },
    { name: "Raina", score: 75 },
    { name: "Rohit", score: 80 }
];


export function ListofPlayers(props) {

    return (
        <div>
            {
                props.players.map((item) => (
                    <div key={item.name}>
                        <li>
                            Mr. {item.name}
                            <span> {item.score}</span>
                        </li>
                    </div>
                ))
            }
        </div>
    );
}

export function Scorebelow70(props) {
    let players70 = [];
    props.players.map((item) => {
        if (item.score <= 70) {
            players70.push(item);
        }
        return null;
    });
    return (
        <div>
            {
                players70.map((item) => (
                    <div key={item.name}>
                        <li>
                            Mr. {item.name}
                            <span> {item.score}</span>
                        </li>
                    </div>
                ))
            }
        </div>
    );
}

export { players };
