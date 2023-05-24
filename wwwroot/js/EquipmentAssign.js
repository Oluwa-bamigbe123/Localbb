const categoryIdSelect = document.querySelector('#CategoryId');
const equipmentSelect = document.querySelector('#EquipmentType');


if (categoryIdSelect != null) {
    categoryIdSelect.addEventListener('change', async (e) => {
        const categoryId = e.target.value;

       // await cookieStore.set("categoryId", categoryId);

        const equipmentSelect = document.querySelector('#EquipmentType');

        equipmentSelect.innerHTML = '<option disabled="" selected="">--Select Equipment--</option>';

        fetch(`/Equipment/GetEquipmentByCategoryId/${categoryId}`, {
            method: "GET"
        })
            .then(res => res.json())
            .then(res => {
                if (equipmentSelect != null) {
                    const distinctOptions = [];

                    res.map(r => {
                        if (!distinctOptions.includes(r.equipmentType)) {
                            distinctOptions.push((r.equipmentType));
                        }
                    })



                    distinctOptions.map(op => {
                        let option = document.createElement('option');
                        option.value = op;
                        option.textContent = op;

                        equipmentSelect.appendChild(option);

                    })



                }
            })

    })
}


if (equipmentSelect != null) {


    equipmentSelect.addEventListener('change', async (e) => {

        const equipmentType = e.target.value.replace(/ /g, "_");
  

        fetch(`/Equipment/GetBrandsByEquipmentType/${equipmentType}`, {
            method: "GET",
            credentials: "same-origin"
        })
            .then(res => res.json())
            .then(res => {
                if (equipmentSelect != null) {
                    const distinctOptions = [];

                    res.map(r => {
                        if (!distinctOptions.includes(r.equipmentType)) {
                            distinctOptions.push((r.equipmentType));
                        }
                    })



                    distinctOptions.map(op => {
                        let option = document.createElement('option');
                        option.value = op;
                        option.textContent = op;

                        equipmentSelect.appendChild(option);

                    })



                }
                console.log(res);
                const brandSelect = document.querySelector('#BrandName');

                brandSelect.innerHTML = '<option disabled="" selected="">--Select Brand--</option>';

                res.map(op => {
                    let option = document.createElement('option');
                    option.value = op.brandName;
                    option.textContent = op.brandName;

                    brandSelect.appendChild(option);
                })
            })
    })
}
