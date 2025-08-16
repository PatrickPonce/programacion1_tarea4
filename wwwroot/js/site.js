document.addEventListener("DOMContentLoaded", () => {
    if (!window.perrosData) return;

    const perros = window.perrosData;
    const container = document.getElementById("perrosContainer");
    const buttons = document.querySelectorAll("#filterButtons [data-filter]");

    function renderPerros(lista) {
        container.innerHTML = "";
        lista.forEach(perro => {
            const col = document.createElement("div");
            col.className = "col-12 col-sm-6 col-md-4 col-lg-3 perro-card";
            col.setAttribute("data-category", perro.Tamano);

            col.innerHTML = `
                <div class="card h-100 shadow-lg border-0 rounded-4 overflow-hidden hover-card">
                    <div class="img-container" style="height:220px;overflow:hidden;">
                        <img src="${perro.Imagen}" class="card-img-top" alt="${perro.Nombre}" style="width:100%;height:100%;object-fit:cover;">
                    </div>
                    <div class="card-body text-center">
                        <h5 class="card-title fw-bold">${perro.Nombre}</h5>
                        <p>
                            ${perro.Tamano === "Pequeño" ? `<span class="badge bg-success fs-6 px-3 py-2">Pequeño</span>` : ""}
                            ${perro.Tamano === "Mediano" ? `<span class="badge bg-warning text-dark fs-6 px-3 py-2">Mediano</span>` : ""}
                            ${perro.Tamano === "Grande" ? `<span class="badge bg-danger fs-6 px-3 py-2">Grande</span>` : ""}
                        </p>
                        <p class="card-text text-muted small mt-3">
                            <strong>Peso:</strong> ${perro.Peso} <br />
                            <strong>Edad:</strong> ${perro.Edad}
                        </p>
                    </div>
                </div>
            `;
            container.appendChild(col);
        });
    }

    renderPerros(perros);

    buttons.forEach(btn => {
        btn.addEventListener("click", () => {
            buttons.forEach(b => b.classList.remove("active"));
            btn.classList.add("active");

            let filter = btn.getAttribute("data-filter");
            let cards = container.querySelectorAll(".perro-card");

            cards.forEach(card => {
                const category = card.getAttribute("data-category");
                if (filter === "Todas" || category === filter) {
                    card.style.display = "block";
                } else {
                    card.style.display = "none";
                }
            });
        });
    });
});
