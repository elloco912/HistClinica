function Cargarmodal() {
	$("#cronogramagrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cronograma/Editar",
			data: {id: id},
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#exampleModal').html(response);
				$('#exampleModal').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});
}

function CargarmodalPersona() {
	$("#personalgrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Persona/Editar",
			data: { idpersona: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#exampleModal').html(response);
				$('#exampleModal').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});
}
