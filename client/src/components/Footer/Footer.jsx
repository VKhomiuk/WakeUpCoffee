import React from 'react'
import Facebook from './assets/facebook.svg'
import Instagram from './assets/instagram.svg'
import Twitter from './assets/twitter.svg'

const Footer = () => {

  return (
    <footer className='bg-black py-20 flex items-center justify-evenly'>
      <div className='font-roboto300 text-3xl text-white text-left'>
        <p>Contact us:</p>
        <p>wakeupcoffe@gmail.com</p>
        <p>+380677777777</p>
      </div>
      <div>
        <p className='text-white text-3xl font-roboto300 mb-2'>Our Social Media:</p>
        <div className='flex items-center gap-2'>
          <img src={Facebook} />
          <img src={Instagram} />
          <img src={Twitter} />
        </div>
      </div>
    </footer>
  )
}

export default Footer
