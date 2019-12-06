
$('#img0').hide();
$('#img1').hide();
$('#img2').hide();
$('#img3').hide();
$('#img4').hide();
$('#img5').hide();
$('#img6').hide();
$('#img7').hide();
$('#img8').hide();
$('#img9').hide();
$('#img10').hide();
$('#img11').hide();
$('#backgroungcolor').hide();
var lettreGlobal;




$('#inputmot').keypress(function(event){
    var keycode = (event.keyCode ? event.keyCode : event.which);
    if(keycode == '13'){
        for (i=0;i<11;i++)
        {
            $('#img'+i).hide();
        }
        var mot=$('#inputmot').val();
        mot=mot.toUpperCase();
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
            if (grandeur==3)
            {
                $('#case'+i).attr("class","col-4");

                if (mot[i]!="*")
                {
                    $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

                }
                else
                {
                    $('#img'+i).attr("src","Letters/CS/CS1.jpg");
                }

                $('#img'+i).show();
                $('#backgroungcolor').show();
            }
            else if(grandeur==4)
            {
                $('#case'+i).attr("class","col-3");

                if (mot[i]!="*")
                {
                    $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

                }
                else
                {
                    $('#img'+i).attr("src","Letters/CS/CS1.jpg");
                }

                $('#img'+i).show();
                $('#backgroungcolor').show();
            }
            else if (grandeur==5 || grandeur==6)
            {
                $('#case'+i).attr("class","col-2");

                if (mot[i]!="*")
                {
                    $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

                }
                else
                {
                    $('#img'+i).attr("src","Letters/CS/CS1.jpg");
                }

                $('#img'+i).show();
                $('#backgroungcolor').show();
            }
            else if(grandeur<=12 || grandeur>6)
            {
                $('#case'+i).attr("class","col-1");

                if (mot[i]!="*")
                {
                    $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

                }
                else
                {
                    $('#img'+i).attr("src","Letters/CS/CS1.jpg");
                }

                $('#img'+i).show();
                $('#backgroungcolor').show();
            }

        }
    }

});





$('#boutton').click(function ()
{
    for (i=0;i<11;i++)
    {
        $('#img'+i).hide();
    }
    var mot=$('#inputmot').val();
    mot=mot.toUpperCase();
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
        if (grandeur==3)
        {
            $('#case'+i).attr("class","col-4");

            if (mot[i]!="*")
            {
                $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

            }
            else
            {
                $('#img'+i).attr("src","Letters/CS/CS1.jpg");
            }

            $('#img'+i).show();
        }
        else if(grandeur==4)
        {
            $('#case'+i).attr("class","col-3");


            if (mot[i]!="*")
            {
                $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

            }
            else
            {
                $('#img'+i).attr("src","Letters/CS/CS1.jpg");
            }
            $('#img'+i).show();
        }
        else if (grandeur==5 || grandeur==6)
        {
            $('#case'+i).attr("class","col-2");

            if (mot[i]!="*")
            {
                $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");

            }
            else
            {
                $('#img'+i).attr("src","Letters/CS/CS1.jpg");
            }

            $('#img'+i).show();
        }
        else if (grandeur<=12 || grandeur>6)
        {
            $('#case'+i).attr("class","col-1");

            if (mot[i]!="*")
            {
                $('#img'+i).attr("src","Letters/"+mot[i]+"/"+mot[i]+"1.jpg");
            }
            else
            {
                $('#img'+i).attr("src","Letters/CS/CS1.jpg");
            }
            $('#img'+i).show();
        }
    }
    $('#backgroungcolor').show();
});





$('#onFerme').click(function ()
{
    $('#exampleModal').modal('hide');
})



$('#CarouselImg1').dblclick(function ()
{
    var sourceIMGdblClick=$(this).attr("src");


    $('#'+lettreGlobal.attr('id')).attr("src",sourceIMGdblClick)
})

$('#CarouselImg2').dblclick(function ()
{
    var sourceIMGdblClick=$(this).attr("src");


    $('#'+lettreGlobal.attr('id')).attr("src",sourceIMGdblClick)
})

$('#CarouselImg3').dblclick(function ()
{
    var sourceIMGdblClick=$(this).attr("src");


    $('#'+lettreGlobal.attr('id')).attr("src",sourceIMGdblClick)
})

$('#CarouselImg4').dblclick(function ()
{
    var sourceIMGdblClick=$(this).attr("src");


    $('#'+lettreGlobal.attr('id')).attr("src",sourceIMGdblClick)
})

$('#CarouselImg5').dblclick(function ()
{
    var sourceIMGdblClick=$(this).attr("src");


    $('#'+lettreGlobal.attr('id')).attr("src",sourceIMGdblClick)
})


$('#img0').click(function ()
{
    $('#exampleModal').modal('show');

    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})


$('#img1').click(function ()
{
    $('#exampleModal').modal('show');
     lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img2').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this).attr("src");
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img3').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img4').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img5').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img6').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img7').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})

$('#img8').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})
$('#img9').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})
$('#img10').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})
$('#img11').click(function ()
{
    $('#exampleModal').modal('show');
    lettreGlobal=$(this);
    var malettre=$(this).attr("src");

    for (i=1;i<=5;i++)
    {
        $('#CarouselImg'+i).attr("src",malettre.substr(0,11)+i+".jpg");
    }
})






$('#boutonVERT').click(function ()
{
    $('#backgroungcolor').css("background-color","green");
})

$('#boutonRouge').click(function ()
{
    $('#backgroungcolor').css("background-color","red");
})

$('#boutonBleu').click(function ()
{
    $('#backgroungcolor').css("background-color","blue");
})

$('#boutonGris').click(function ()
{
    $('#backgroungcolor').css("background-color","grey");
})

$('#boutonJaune').click(function ()
{
    $('#backgroungcolor').css("background-color","yellow");
})

$('#boutonNoir').click(function ()
{
    $('#backgroungcolor').css("background-color","black");
})






