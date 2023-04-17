import logo from './assets/Logo.png'
import Cart from './assets/Cart.svg'

const Header = () => {



  return (
    <header className='flex items-center justify-between bg-black px-8'>
      <img src={logo} width='203px' height='65px' />

      {false ? <VisitorMode /> : <UserMode />}
    </header>
  )
}

const VisitorMode = () => {
  return (
    <div className='flex items-center gap-5 font-roboto500 text-chocolate text-2xl'>
      <a>Log in</a>
      <a>Sign up</a>
    </div>
  )
}

const UserMode = () => {
  return (
    <div className='flex items-center gap-5 font-roboto500 text-chocolate text-2xl'>
      <a href='/cart'>
        <img src={Cart} />
      </a>
      <a>Log out</a>
    </div>
  )
}

export default Header
