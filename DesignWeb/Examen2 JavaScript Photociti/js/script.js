$('#inputmot').keypress(function(event){
    var keycode = (event.keyCode ? event.keyCode : event.which);
    if(keycode == '13'){
        var mot=$('#inputmot').val();

        var grandeur=mot.length;

        if (grandeur<3)
        {
            alert("Votre mot est trop court ");
        }
        else if (grandeur>12)
        {
            alert("Votre mot est trop long");
        }

        for (i=0;i<mot.length;i++)
        {
            $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

        }
    }
});





$('#boutton').click(function ()
{

    var mot=$('#inputmot').val();

    var grandeur=mot.length;

    if (grandeur<3)
    {
        alert("Votre mot est trop court ");
    }
    else if (grandeur>12)
    {
        alert("Votre mot est trop long");
    }

    for (i=0;i<mot.length;i++)
    {
        $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

    }

});


