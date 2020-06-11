﻿$(document).on('change', '#idmedico', function (event) {

		console.log("entro");
		BuscarCronograma();

});


function Cargarmodal() {
	$("#cronogramagrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cronograma/Editar",
			data: { id: id },
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
				$('#modalestado').html(response);
				$('#modalestado').modal('show');
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

function CargaConsultaCronograma() {
		$.ajax({
			type: "GET",
			url: "/Cronograma/ConsultarCronograma",
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalcronograma').html(response);
				$('#modalcronograma').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
}

function BuscarCronograma() {
	var idmedico = $("#idmedico option:selected").val();
		$.ajax({
			type: "GET",
			url: "/Cronograma/ConsultarCronogramapost",
			data: { id: idmedico },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalcronograma').html(response);
				$('#modalcronograma').modal('show');
				console.log(response);
				//$('#modalestado').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
}

function CargaModalCitas() {
	$.ajax({
		type: "GET",
		url: "/Cita/Registro",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalcitas').html(response);
			$('#modalcitas').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function BuscarPaciente() {
	var id = $('#modalcitas #dni').val();
	var idEmpleado = $("#modalcitas #medico option:selected").val();
	$.ajax({
		type: "GET",
		url: "/Cita/BuscarDni",
		data: { dni: id },
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (response) {
			console.log(response);
			$('#modalcitas #nombrepaciente').val(response.primerNombre + ' ' + response.apellidoPaterno + ' ' + response.apellidoMaterno);
			console.log(response.paciente.idPaciente);
			$('#modalcitas #idpaciente').val(response.paciente.idPaciente);

		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function CargarModalReprogramar() {
	$("#citagrid .edit").click(function () {
			var id = $(this).closest("tr").find("td").eq(0).html();
			$.ajax({
				type: "GET",
				url: "/Cita/Edit",
				data: { id: id },
				contentType: "application/json; charset=utf-8",
				dataType: "html",
				success: function (response) {
					$('#modalreprogramar').html(response);
					$('#modalreprogramar').modal('show');
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