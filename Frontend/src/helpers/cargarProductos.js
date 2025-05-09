import { obtenerProductos } from "../services/productoService.js";
import { mostrarMensaje } from "./mostrarMensaje.js";
import { asignarEventosBotones } from "./asignarEventosBotones.js";

export async function cargarProductos() {
    const listaProductos = document.getElementById("listaProductos");
    listaProductos.innerHTML = "";

    try {
        const productos = await obtenerProductos();

        if (productos.length === 0) {
            listaProductos.innerHTML = "<li>No hay productos registrados.</li>";
            return;
        }

        productos.forEach((producto) => {
            const li = document.createElement("li");
            li.className = "producto-item";
            li.innerHTML = `
                <strong>${producto.nombre}</strong><br>
                Precio: ${producto.precioUnitario}<br>
                Descripción: ${producto.descripcion}
                <div class="botones-acciones">
                    <button class="btn-editar" data-id="${producto.id}">Editar</button>
                    <button class="btn-eliminar" data-id="${producto.id}">Eliminar</button>
                </div>
            `;
            listaProductos.appendChild(li);

            // Asignar eventos a los botones de editar y eliminar
            asignarEventosBotones(li);
        });
    } catch (error) {
        console.error("Error al cargar los productos:", error);
        mostrarMensaje("No se pudieron cargar los productos.", "error");
    }
}
