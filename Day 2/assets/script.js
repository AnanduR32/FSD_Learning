var teams = ['team1', 'team2', 'team3']
var availablePlayerCount = document.getElementById('players').childElementCount
console.log(availablePlayerCount);
window.onload = function () {
    // setPlayerNames();
};
function setPlayerNames() {
    for (let i = 1; i < 10; i++) {
        document.getElementById('player' + i).innerHTML = '<p>player ' + i + '</p>'
    }
}


function allowDragToDiv(event) {
    event.preventDefault();
}
function dragStart(event) {
    var id = event.target.id;
    console.log(id);
    sessionStorage.id = id;
}

function dropAtTargetDiv(event) {
    var id = sessionStorage.id;

    var currentTeam = event.target.id;
    var tmpTeam = teams.filter(x => !currentTeam.includes(x))

    var reqPlayerExtra = 0

    for (var team of tmpTeam) {
        var teamCount = document.getElementById(team).childElementCount
        console.log(teamCount)
        if (teamCount == 0) {
            reqPlayerExtra += 1
        }
    }
    console.log(`avail: ${availablePlayerCount}\nreq: ${reqPlayerExtra}`)
    if (reqPlayerExtra >= availablePlayerCount) {
        alert('Some teams have not been filled!')
    } else {
        element = document.getElementById(id);
        event.target.appendChild(element);
        availablePlayerCount -= 1;
        console.log(id + " in " + event.target.id);
    }

}
