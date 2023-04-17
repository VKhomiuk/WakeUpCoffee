import MenuItem from './assets/coffee.png'
import Arrow from './assets/Arrow.svg'
import Bin from './assets/Bin.svg'
import { useState } from 'react'

const CartItems = () => {


  const cartItems = [
    {
      img: MenuItem,
      title: 'Еспресо',
      description: 'Дивовижна та ароматна, зухвала і збудлива, міцна і злегка гіркувата. Саме такою є кава еспресо - справжня кава для справжнього життя!',
      cookTime: '1 хв',
      price: '18 грн',
      id: 0,
      additionals: [
        { title: 'lorem sdi sdki ', description: '3sasjd hjsd hjsad', price: '15uah' },
        { title: 'lorem sdi sdki ', description: '3sasjd hjsd hjsad', price: '15uah' },
      ]
    },
    {
      img: MenuItem,
      title: 'Еспресо',
      description: 'Дивовижна та ароматна, зухвала і збудлива, міцна і злегка гіркувата. Саме такою є кава еспресо - справжня кава для справжнього життя!',
      cookTime: '1 хв',
      price: '18 грн',
      id: 1,
      additionals: [
        { title: 'lorem sdi sdki ', description: '3sasjd hjsd hjsad', price: '15uah' },
        { title: 'lorem sdi sdki ', description: '3sasjd hjsd hjsad', price: '15uah' },
      ]
    }

  ]

  return (
    <div className='mb-20'>
      <h3 className='underline text-black font-roboto500 text-5xl mt-8 mb-10'>Корзина</h3>
      <div className='flex flex-col gap-10'>
        {cartItems.map(el => <MenuCart {...el} />)}
      </div>
    </div>
  )
}

const MenuCart = ({ img, title, description, cookTime, price, id, additionals }) => {

  const [openedAdditions, setOpenedAdditions] = useState(false)

  return (
    <div className='bg-lemonade py-10'>
      <div className='flex flex-wrap w-9/12 mx-auto justify-between items-center gap-12'>
        < img src={img} />
        <div className='text-left flex flex-col flex-auto w-6/12 justify-between h-full'>
          <div className='flex justify-between items-center mb-6'>
            <h5 className='font-inter font-bold text-4xl'>{title}</h5>
            <img src={Bin} />
          </div>
          <p className='font-inter font-regular text-black text-3xl mb-5'>{description}</p>
          <p className='font-roboto500 text-4xl text-black'>Час приготування: {cookTime}</p>
          <p className='font-roboto500 text-4xl text-black'>Ціна: {price}</p>
          <div className=' mt-10 '>
            <div className='flex bg-caramel rounded-xl py-3 px-6 items-center justify-between w-full' >
              <p className='font-roboto500 text-4xl text-black'>Додатки</p>
              <div onClick={() => setOpenedAdditions(!openedAdditions)} className='relative flex items-center justify-center w-9 h-9 bg-nude rounded-full'>
                <img className={openedAdditions ? 'transform rotate-180' : ''} src={Arrow} />
              </div>
            </div>
            {openedAdditions && <div className='bg-chocolate py-3 px-6'>
              {additionals.map(el => <AdditionTile {...el} />)}
            </div>}
          </div>
        </div>
      </div >
    </div >
  )
}

const AdditionTile = ({ title, description, price }) => {
  return (
    <div className='flex flex-col'>
      <h5 className='font-roboto500 text-4xl text-white'>{title}</h5>
      <div className='ml-16 flex justify-between my-4 items-center font-roboto500 text-white text-3xl'>
        <p>{description}</p>
        <p>{price}</p>
      </div>
    </div>
  )
}

export default CartItems
