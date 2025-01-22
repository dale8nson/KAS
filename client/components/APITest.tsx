export const APITest = async () => {
    let res, text
    try {
        res = await fetch("http://localhost:5252/api/ChartOfAccounts/3")
    text = await res.text()
} catch (error) {
    if (error instanceof Error) {
        console.log(error)
    } else {
        console.log(String(error))
    }
}

    return (
        <div>
            <h1>{text}</h1>
        </div>
    )
}