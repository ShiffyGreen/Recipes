import type { ICuisine } from "./DataInterfaces";

interface Props {
  cuisine: ICuisine
  isSelected?: boolean;
  onSelected: (cuisine: ICuisine) => void;
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {

  return (
    <div onClick={() => onSelected(cuisine)} className={`btn ${isSelected ? 'btn-secondary' : ""} `}>
      <figure className="figure" style={{ width: "120px", height: "120px", margin: "0 auto" }}>
        <img
          src={`/images/cuisine-images/${cuisine.cuisineType.toLowerCase()}.jpg`}
          className="figure-img img-fluid rounded"
          alt=""
          style={{ width: "100%", height: "100%", objectFit: "cover" }}
        />
        <figcaption className="figure-caption text-center">{cuisine.cuisineType}</figcaption>
      </figure>
    </div>
  )
}