// URL para listar los solicitantes
const listUrl = 'http://24.199.91.179:8082/api/solicitantes';

// Hacer la solicitud GET
function listarSolicitantes() {
  fetch(listUrl, {
    method: 'GET',
    headers: {
      'Content-Type': 'application/json'  // Indicar que la respuesta será JSON
    }
  })
  .then(response => {
    if (!response.ok) {
      throw new Error(`Error al listar solicitantes: ${response.statusText}`);
    }
    return response.json();  // Parsear la respuesta JSON
  })
  .then(data => {
    console.log('Lista de solicitantes:', data);
  })
  .catch(error => {
    console.error('Error en la solicitud GET:', error);
  });
}

// Llamar a la función para listar los solicitantes
listarSolicitantes();
