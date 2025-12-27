// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function mostrarcarga() {
    var alerta = bootbox.alert({
        message: '<div class="text-center"><img src="/imagenes/cargar.gif" /> </div>',
        closeButton: false,
        buttons: {
            ok: {
                label: 'Yes',
                className: 'pcss'
            },

        },


    });
    return alerta;

}
