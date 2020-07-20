// codificando utf 8 para base64



function ToBase64()
{
	//obtendo o texto escrito no textarea
    texto = document.getElementById("input-text").value; 
    //tenta converter a chave, caso dê erro retorna msg de "chave invalida"
	try 
	{
	   document.getElementById("input-text").value = window.atob(texto);;
	}
	catch (e) {alert ("Chave Inserida é Inválida!");}
   

}


