import { mostrarMensaje } from "./mostrarMensaje.js";

export function validarFormulario(data) {
    if (!data.nombre || !data.precioUnitario || !data.descripcion) {
        mostrarMensaje("Por favor complete los campos.", "error");
        return false;
    }

    if (isNaN(data.precioUnitario) || data.precioUnitario <= 0) {
        mostrarMensaje("El precio debe ser un número positivo.", "error");
        return false;
    }

    if (data.descripcion.length > 200) {
        mostrarMensaje(
            "La descripción no puede exceder los 200 caracteres.",
            "error"
        );
        return false;
    }

    if (data.nombre.length > 50) {
        mostrarMensaje(
            "El nombre no puede exceder los 50 caracteres.",
            "error"
        );
        return false;
    }

    return true;
}
