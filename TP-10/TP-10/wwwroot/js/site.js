function MostrarInfo(IdS){
     $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            URL: '/Home/Series',
            data: { IdSerie : IdS},
            success:
            function (response){
                $("#NombreSerie").html(response.nombre);
                $("#AnioInicio").html(response.anio.substr(0.9));
                $("#SinopsisSerie").html(response.sinopsis);
                $("#FotoSerie").attr("src", "/" + response.imagenserie);
            }
        }
     )
}

function MostrarInfoActor(IdA){
    $.ajax(
       {
           type: 'POST',
           dataType: 'JSON',
           URL: '/Home/Actor',
           data: { IdActor : IdA},
           success:
           function (response){
               $("#NombreActor").html(response.nombre);
           }
       }
    )
}

function MostrarInfoTemporadas(IdT){
    $.ajax(
       {
           type: 'POST',
           dataType: 'JSON',
           URL: '/Home/Temporada',
           data: { IdTemporada : IdT},
           success:
           function (response){
               $("#NumeroTemporada").html(response.numerotemporada);
               $("#TituloTemporada").html(response.titulotemporada);
           }
       }
    )
}