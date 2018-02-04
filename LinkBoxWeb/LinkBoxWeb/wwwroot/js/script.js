$(document).ready(function() {

    $('#search').click(function()
    {
        var searched = $('#whateveryouwant').val().toUpperCase();

        var searchedtext = document.querySelectorAll("." + searched);
        var notext = document.querySelectorAll(".card");

        for(var i = 0; i < notext.length; i++)
        {
            notext[i].classList.remove("show");
            notext[i].classList.add("hide");

        }


        for(var i = 0; i < searchedtext.length; i++)
        {
            searchedtext[i].classList.remove("hide");
            searchedtext[i].classList.add("show");

        }




    });

    $().button('toggle');
    $('#all').click(function()
    {
        var text = document.querySelectorAll(".card");
        for(var i = 0; i < text.length; i++)
        {
            text[i].classList.remove("hide");
            text[i].classList.add("show");
        }
    });

    $('#library').click(function()
    {
        var librarytext = document.querySelectorAll(".LIBRARY");
        var exercisetext = document.querySelectorAll(".EXERCISE");

        for(var i = 0; i < librarytext.length; i++)
        {
            librarytext[i].classList.remove("hide");
            librarytext[i].classList.add("show");

        }

        for(var i = 0; i < exercisetext.length; i++)
        {
            exercisetext[i].classList.remove("show");
            exercisetext[i].classList.add("hide");

        }
    });

    $('#exercise').click(function()
    {
        var librarytext = document.querySelectorAll(".LIBRARY");
        var exercisetext = document.querySelectorAll(".EXERCISE");

        for(var i = 0; i < librarytext.length; i++)
        {
            librarytext[i].classList.remove("show");
            librarytext[i].classList.add("hide");

        }

        for(var i = 0; i < exercisetext.length; i++)
        {
            exercisetext[i].classList.remove("hide");
            exercisetext[i].classList.add("show");

        }
    });


});