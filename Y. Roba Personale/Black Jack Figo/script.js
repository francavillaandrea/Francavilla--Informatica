const socket = io();

let playerId = null;
let gameStarted = false;

socket.on('connect', () => {
    playerId = socket.id;
    console.log('Sei connesso con ID:', playerId);
});

socket.on('gameStarted', (bet) => {
    gameStarted = true;
    document.getElementById('message').textContent = `Partita avviata con puntata ${bet}`;
});

socket.on('cardDrawn', ({ playerId, card }) => {
    const cardElement = document.createElement('div');
    cardElement.className = 'card';
    cardElement.style.backgroundImage = `url('assets/${card}.png')`;
    document.getElementById(playerId === socket.id ? 'player-cards' : 'dealer-cards').appendChild(cardElement);
});

function startGame() {
    const bet = document.getElementById('bet').value;
    if (bet && !gameStarted) {
        socket.emit('startGame', bet);
    }
}

function drawCard() {
    if (gameStarted) {
        socket.emit('drawCard', playerId);
    }
}

function endTurn() {
    if (gameStarted) {
        socket.emit('endTurn', playerId);
    }
}