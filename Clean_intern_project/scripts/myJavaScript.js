
var voteValue;

$(document).ready(function(){
    $("Ballot, .option").click(function () {
        voteValue = $(this).val();
        vote();
    });

});

function submitVote() {
    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange =
        function () {
            if (xhttp.readyState === 4 && xhttp.status === 200) {
                document.getElementById("testdiv").innerHTML = xhttp.responseText;
            }
        };

    xhttp.open("GET", "/Home/Test?vote=" + voteValue, true);
    xhttp.send();
}

function submitVote1() {
    $.ajax({
        url: "/Home/Test?vote=" + voteValue,
        success: processVoteData
    });
}

function processVoteData(voteData, textStatus, jqXHR)
{
    $("#testdiv").html(voteData);
}




