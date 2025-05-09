import { manejarFormulario } from "./helpers/manejarFormulario.js";
import { cargarProductos } from "./helpers/cargarProductos.js";

document
    .getElementById("formularioProducto")
    .addEventListener("submit", manejarFormulario);

cargarProductos();
