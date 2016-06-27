
// This is the javascript for the JoinSessionView

var voteValue;

$(document).ready(function () {
    $("Ballot, .option").click(function () {
        voteValue = $(this).val();
        vote();
    });

});

function selectVote() {
    voteValue = $(this).val();
}

function submitVote() {
    $.ajax({
        url: "/VotingSession/Vote?vote=" + voteValue + "&guid=" + $("#sessionGuid").val(),
        success: processVoteData
    });
}

function processVoteData(voteData, textStatus, jqXHR) {
    $("#testdiv").html(voteData);
}
