import type { ICuisine } from "./DataInterfaces";

interface Props {
  cuisine: ICuisine
  isSelected?: boolean;
  onSelected: (cuisine: ICuisine) => void;
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {

  return (
    <div onClick={() => onSelected(cuisine)} className={`btn ${isSelected ? 'btn-secondary' : ""} `}>
      <figure className="figure">
        <img src={`/images/cuisine-images/${cuisine.cuisineType.toLowerCase()}.jpg`} className="figure-img img-fluid rounded" alt="" />
        <figcaption className="figure-caption text-center">{cuisine.cuisineType}</figcaption>
      </figure>
    </div>
  )
}