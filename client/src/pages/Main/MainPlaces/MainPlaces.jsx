import Place from './assets/place.png'
import { useHistory } from 'react-router-dom'

const MainPlaces = () => {

  const places = [
    { img: Place, name: 'Coffee shop name', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium ultrices semper.', id: 0 },
    { img: Place, name: 'Coffee shop name', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium ultrices semper.', id: 1 },
  ]

  return (
    <div className='w-8/12 mx-auto mt-16'>
      <h3 className='font-roboto400 text-3xl mb-6 text-black'>Nearest coffe shops to your location</h3>
      <div className='flex flex-row flex-wrap justify-between items-center mb-24' >
        {places.map(el => <PlaceTile {...el} />)}
      </div>
    </div>
  )
}

const PlaceTile = ({ img, name, description, id }) => {
  return (
    <a className='w-5/12 flex flex-col items-center cursor-pointer justify-center' href={`/place/${id}`}>
      <img className='' src={img} />
      <h6 className='font-roboto500 text-3xl mt-3 text-black'>{name}</h6>
      <p className='font-roboto300 text-black text-xl'>{description}</p>
    </a>
  )
}

export default MainPlaces
