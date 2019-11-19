$('#Starwars').hide();

$('#DC').hide();

$('#Marvel').hide();






$('#STARWARSB').click(function ()
{
    $('#DC').hide();
    $('#Marvel').hide();
    $('#Starwars').show();
})

$('#DCB').click(function ()
{
    $('#Starwars').hide();
    $('#Marvel').hide();
    $('#DC').show();
})

$('#MarvelB').click(function ()
{
    $('#Starwars').hide();
    $('#DC').hide();
    $('#Marvel').show();
})


$('#inputNom').keyup(function ()
{
    var nom=$('#inputNom').val();
 if (nom=="SLAY" || nom=="Test")
 {
    $('#blyat').css("color","red")
     $('#blyat').html("nom invalide");
     $('#blyat2').css("color","red")
     $('#blyat2').html("nom invalide");
     $('#blyat3').css("color","red")
     $('#blyat3').html("nom invalide")
 }
 else
 {
     $('#blyat').css("color","green")
     $('#blyat').html("nom valide");
     $('#blyat2').css("color","green")
     $('#blyat2').html("nom valide");
     $('#blyat3').css("color","green")
     $('#blyat3').html("nom valide")
 }
})

function hasUpperCase(str) {
    return (/[A-Z]/.test(str));
}
function hasNumber(str) {
    return (/[0-9]/.test(str));
}


$('#inputMDP').keyup(function ()
{
    var mdp=$('#inputMDP').val();
    var grandeur=mdp.length;
    if(grandeur<6)
    {
        $('#forceMDP').html("faible")
        $('#forceMDP').css("color","red")
    }

    else if(grandeur>=6 && grandeur<9)
    {
        $('#forceMDP').html("Moyen")
        $('#forceMDP').css("color","yellow")
    }
    else if(grandeur>9 && hasUpperCase(mdp) && hasNumber(mdp))
    {
        $('#forceMDP').html("Fort")
        $('#forceMDP').css("color","green")
    }
})


$('#inputMDPC').keyup(function ()
{
    var mdp=$('#inputMDP').val();
    var confmdp=$('#inputMDPC').val();

    if(mdp==confmdp)
    {
        $('#confmdp').html("mots de passe identique")
        $('#confmdp').css("color","green")
    }
    else
    {
        $('#confmdp').html("mots de passe non-identique")
        $('#confmdp').css("color","red")
    }
})

$('#inputcourriel').keyup(function ()
{
    var courriel=$('#inputcourriel').val();

    if(courriel.includes(".")&& courriel.includes("@"))
    {
        $('#yeet').html("Email valide");
    }
    else
    {
        $('#yeet').html("Email non-valide");
    }

})

$('#yodaB').click(function ()
{
    $('#SWimgSELEC').attr("src","img/yoda-810x456.jpg");
})

$('#obiwanB').click(function ()
{
    $('#SWimgSELEC').attr("src","img/obiwan-feat-min.jpg");
})

$('#DarthVaderB').click(function ()
{
    $('#SWimgSELEC').attr("src","img/VaderImmortal2-810x456.jpg");
})

$('#spidermanB').click(function ()
{
    $('#MARVELimgSELEC').attr("src","img/spiderman-810x456.jpg");
})

$('#ThorB').click(function ()
{
    $('#MARVELimgSELEC').attr("src","img/thor-810x456.jpg");
})

$('#HulkB').click(function ()
{
    $('#MARVELimgSELEC').attr("src","img/hulk-costume-810x456.jpg");
})

$('#BatmanB').click(function ()
{
    $('#DCIMGSELEC').attr("src","img/batman.jpg");
})

$('#supermanB').click(function ()
{
    $('#DCIMGSELEC').attr("src","img/superman-810x456.jpg");
})

$('#flashB').click(function ()
{
    $('#DCIMGSELEC').attr("src","img/flash-810x456.jpg");
})

$('#arrowB').click(function ()
{
    $('#DCIMGSELEC').attr("src","img/Arrow-seizoen-6-Netflix-1-810x456.jpg");
})





$('.btnMort').click(function ()
{
    var nom=$('#inputNom').val();
    var mdp=$('#inputMDP').val();
    var courriel=$('#inputcourriel').val();


    var radioValue = $("input[name='univers']:checked").val();

    if (radioValue=="StarsWars")
    {
        var radioValueReal = $("input[name='perso']:checked").val();
    }
    else if (radioValue=="DC")
    {
        var radioValueReal = $("input[name='perso1']:checked").val();
    }
    else if(radioValue==="Marvel")
    {
        var radioValueReal = $("input[name='perso2']:checked").val();
    }


    alert("Votre nom est : "+nom+". Votre mdp est: "+mdp+". Votre courriel est: "+courriel+
        ". Votre image est : "+radioValueReal);
})



