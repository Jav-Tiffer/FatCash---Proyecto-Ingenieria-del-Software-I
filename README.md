# FatCash — Ingeniería del Software I

**Escritorio / Finanzas personales.** Aplicación básica para registrar **ingresos** y **gastos** y visualizar el **balance** del usuario.

## Contexto del curso
- **Curso:** Ingeniería del Software I
- **Modalidad:** 1ª mitad centrada en documentación y proceso; 2ª mitad en desarrollo
- **Equipo:** Proyecto colaborativo (planificación, sprints, incrementos, alcance y nombre)
- **Rol personal:** Primer proyecto programable (paralelo a Programación I)

## Objetivo del proyecto
- Construir una app de escritorio que permita:
  - Registrar **gastos** e **ingresos**.
  - Calcular y mostrar el **balance**.
  - Mantener una estructura simple para practicar ciclo de vida y disciplina de equipo.

## Stack y herramientas
- **Lenguaje:** Visual Basic .NET.  
- **IDE:** Visual Studio (WinForms/WPF).  
- **Estructura del repo:**  
  - `Fatcash/` — Código fuente de la app.  
  - `Documentacion/` — Entregables del proceso (análisis, sprints, etc.).  

## Lo que aprendí
- **Proceso primero, código después:** a definir **sprints**, alcance y criterios antes de programar.
- **Trabajo en equipo:** a distribuir tareas y sostener el avance con entregables de documentación.
- **Bases de programación:** primeros pasos en estructuras, formularios y eventos en un entorno de escritorio.
- **MVP realista:** priorizar lo esencial (altas de ingresos/gastos y balance) para llegar a tiempo.

## Decisiones técnicas clave
- **App de escritorio sencilla** para reducir complejidad y enfocarnos en el proceso de ingeniería.
- **Persistencia mínima** (sin BD compleja) en esta primera versión para no bloquear el avance del curso.
- **Interfaz directa** (formularios/controles) para acelerar validaciones con el profesor y el equipo.

## Arquitectura (breve)
- **Capa UI:** formularios para capturar ingresos/gastos y mostrar balance.
- **Lógica:** cálculo de totales y validaciones básicas.
- **Datos:** almacenamiento básico local (según alcance de la versión del curso).

## Próximos pasos / mejoras
- Agregar categorías y filtros por rango de fechas.
- Exportar reportes (CSV/Excel).
- Gráficas simples (pastel/barras) para evolución mensual.
- Persistencia más robusta (p. ej., SQLite) y pruebas unitarias.

## Créditos
Proyecto desarrollado en equipo para Ingeniería del Software I.
- Javier Guzman
- Gabriel Barrientos
- Gabriel Aguilar
- Yossef Acevedo