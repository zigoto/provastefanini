function Confirmacao(url) {
    $("#LightBoxMensagem").show();
    $("#Mensagem").show();
    $("#Mensagem #BotoesConfirmacao").show();
    $("#Mensagem #TituloMensagem").html("Atenção");
    $("#Mensagem #ConteudoMensagem").html("Tem certeza que deseja excluir esse item?");

    $("#Mensagem").removeClass();
    $("#Mensagem").addClass("mensagem-alerta");

    $("#btnConfirmacao").attr("href", url)
}