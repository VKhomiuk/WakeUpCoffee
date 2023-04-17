import MainBg from './assets/titleBg.png'
import Facebook from './assets/facebook.svg'
import Instagram from './assets/instagram.svg'
import Twitter from './assets/twitter.svg'

const MainTitle = () => {

  return (
    <div className='relative'>
      <img className='w-full h-full -mt-2' src={MainBg} />
      <div className='absolute top-96 right-96'>
        <div className='relative'>
          <h1 className='font-kalam400 text-chocolate text-7xl mb-4'>WakeUpCoffee</h1>
          <h1 className='font-kalam400 text-chocolate absolute -top-1 opacity-20 left-14 text-7xl mb-4'>WakeUpCoffee</h1>
        </div>
        <p className='font-julius text-chocolate ml-32 text-4xl'>MAKE YOUR DAY BETTER</p>
        <hr className='border border-chocolate ml-52 my-3' />
        <div className='flex items-center gap-2 ml-52'>
          <img src={Facebook} />
          <img src={Instagram} />
          <img src={Twitter} />
        </div>
      </div>
    </div>
  )
}

export default MainTitle
