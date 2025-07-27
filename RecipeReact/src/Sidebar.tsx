import { useEffect, useState } from "react";
import type { ICuisine } from "./DataInterfaces";
import { fetchCuisine } from "./DataUtil";
import CuisineButton from "./Cuisine";

interface Props {
    onCuisineSelected: (cuisineId: number) => void;
}

export default function Sidebar({ onCuisineSelected }: Props) {
    const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisine, setSelectedCuisine] = useState(1);
    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisine();
            setCuisineList(data);
            if (data.length > 0) {
                setSelectedCuisine(data[0].cuisineId);
            }
        };
        fetchdata();
    }, []);
    function handleSelectedCuisine(cuisine: ICuisine) {
        setSelectedCuisine(cuisine.cuisineId);
        onCuisineSelected(cuisine.cuisineId);
    }
    return (
        <>
            <h2>
                {cuisineList.map(c =>
                    <CuisineButton key={c.cuisineId} cuisine={c} onSelected={handleSelectedCuisine} isSelected={c.cuisineId == selectedCuisine} />)}
            </h2>
        </>
    );
}