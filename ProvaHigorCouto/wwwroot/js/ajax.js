function AjaxPOST(url, parametro, callBack) {
    ExibirLoad();
    $.ajax({
        type: "POST",
        url: url,
        data: parametro,
        traditional: true
    }).done(function (obj) {
        callBack(obj);
    }).fail(function (jqXHR, textStatus, error) {
        ExibirMensagem("DESCULPE-NOS", "Um erro inesperado ocorreu =[", TipoMensagem.Erro);
        OcultarLoad();
    });
}

function ExibirLoad() {
    $("#loader").show();
}

function OcultarLoad() {
    $("#loader").hide();
}