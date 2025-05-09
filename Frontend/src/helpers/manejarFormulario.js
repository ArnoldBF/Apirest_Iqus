import {
    actualizarProducto,
    crearProducto,
} from "../services/productoService.js";
import { mostrarMensaje } from "./mostrarMensaje.js";
import { cargarProductos } from "./cargarProductos.js";

import { validarFormulario } from "./validarFormulario.js";

export async function manejarFormulario(evento) {
    evento.preventDefault();

    const mensaje = document.getElementById("mensaje");
    mensaje.style.display = "none";

    const data = {
        nombre: document.getElementById("nombre").value,
        precioUnitario: document.getElementById("precioUnitario").value,
        descripcion: document.getElementById("descripcion").value,
    };

    if (!validarFormulario(data)) {
        return;
    }

    const botonSubmit = document.querySelector(
        "#formularioProducto button[type='submit']"
    );

    try {
        if (botonSubmit.textContent === "Actualizar Producto") {
            const id = botonSubmit.getAttribute("data-id");
            data.id = id;
            await actualizarProducto(data);
            mostrarMensaje("Producto actualizado exitosamente.", "exito");
        } else {
            await crearProducto(data);
            mostrarMensaje("Producto registrado exitosamente.", "exito");
        }

        await cargarProductos();
        document.getElementById("formularioProducto").reset();
        botonSubmit.textContent = "Registrar Producto";
        botonSubmit.removeAttribute("data-id");
    } catch (error) {
        console.error("Error al procesar el formulario:", error);
        mostrarMensaje(error.message, "error");
        document.getElementById("formularioProducto").reset();
        botonSubmit.textContent = "Registrar Producto";
        botonSubmit.removeAttribute("data-id");
    }
}
