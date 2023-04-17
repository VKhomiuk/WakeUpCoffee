import Facebook from './assets/facebook.svg'
import Instagram from './assets/instagram.svg'
import Twitter from './assets/twitter.svg'
import PlaceLogo from './assets/placeLogo.png'

const PlacePageTitle = () => {
  return (
    <div className='relative'>
      <img className='w-full h-full' src={PlaceLogo} />
      <div className='absolute left-20 top-64'>
        <h3 className='font-julius text-5xl text-white'>Bigman Coffee</h3>
        <hr className='py-2' />
        <div className='flex items-start gap-7'>
          <div className='flex flex-col items-center gap-2'>
            <img src={Facebook} />
            <img src={Instagram} />
            <img src={Twitter} />
          </div>
          <div className='text-left font-roboto100 text-white text-4xl'>
            <p>Open hours:</p>
            <p>Mon 9:00 - 17:00</p>
            <p>Tue 9:00 - 17:00</p>
            <p>Wed 9:00 - 17:00</p>
            <p>Thu 9:00 - 17:00</p>
            <p>Fru 9:00 - 17:00</p>
            <p>Sat 9:00 - 17:00</p>
            <p>Sun 9:00 - 17:00</p>
            <button className='mt-6 rounded-3xl bg-green-500 py-5 px-10 font-roboto700 text-black text-4xl' >Show on map</button>
          </div>
        </div>
      </div>
    </div>
  )
}

export default PlacePageTitle
