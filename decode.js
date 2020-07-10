// codificando utf 8 para base64

function decode()

{
  texto = document.getElementById("input-text").value;
   
  var enc = window.atob(texto);
  document.getElementById("input-text").value = window.atob(texto);

  

}
   

