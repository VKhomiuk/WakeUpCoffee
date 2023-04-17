import Close from './assets/close.svg'

const Signup = () => {
  return (
    <div className='absolute '>
      <img src={Close} />
      <h3 className='underline text-black font-roboto500 text-5xl mt-8 mb-10'>Sign up form</h3>
      <form>
        <input placeholder='Name' className='rounded-xl bg-transparent border border-black font-roboto400 text-4xl px-8 py-5' />
      </form>
    </div>
  )
}

export default Signup
